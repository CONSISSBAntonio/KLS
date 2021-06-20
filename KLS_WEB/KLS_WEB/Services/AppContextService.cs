using KLS_WEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KLS_WEB.Services
{
    public interface IAppContextService
    {
        Task<ResponseModel> ExecuteHttpPost(string Path, dynamic Data);

        Task<T> Execute<T>(Enum EnumMethod, string Path, dynamic Data) where T : new();

        Task<(T, string, string)> ExecuteAPI<T>(Enum EnumMethod, string Path, dynamic DataModel) where T : new();
    }

    public class AppContextService : IAppContextService
    {
        private IConfiguration Configuration { get; }

        private MethodType EnumMethod { get; set; }

        HttpClient _client;
        private readonly IHttpContextAccessor HttpContextAccessor;
        public AppContextService(IConfiguration _Configuration, IHttpContextAccessor _httpContextAccessor)
        {

            _client = new HttpClient();
            Configuration = _Configuration;
            this.HttpContextAccessor = _httpContextAccessor;
        }

        public async Task<ResponseModel> ExecuteHttpPost(string Path, dynamic Data)
        {
            ResponseModel _responseModel = new ResponseModel();

            using (var _request = new HttpRequestMessage())
            {
                _request.Content = new StringContent(JsonConvert.SerializeObject(Data));
                _request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                _request.Method = new HttpMethod("POST");
                _request.RequestUri = new Uri(this.Configuration["Api:Url"] + Path, System.UriKind.RelativeOrAbsolute);
                _request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));


                var response_ = await _client.SendAsync(_request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

                // OBTENEMOS EL Content DEL RESPONSE como un String
                // Utilizamos ConfigureAwait(false) para evitar el DeadLock.
                var responseText_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);

                // SI ES LA RESPUESTA ESPERADA !! ...
                if (response_.StatusCode == System.Net.HttpStatusCode.OK) // 200
                {
                    // DESERIALIZAMOS Content DEL RESPONSE
                    // var responseBody_ = JsonConvert.DeserializeObject<T>(responseText_);
                    _responseModel.Code = "200";
                    _responseModel.Data = responseText_;
                    return _responseModel;
                }
                else
                //InternalServerError
                if (response_.StatusCode == System.Net.HttpStatusCode.InternalServerError) // 500
                {
                    // InternalServerError
                    // throw new Exception("500 InternalServerError. Las credenciales de acceso del usuario son incorrectas. " + responseText_);
                    _responseModel.Code = "500";
                    _responseModel.Message = JsonConvert.DeserializeObject<object>(responseText_).ToString();
                }
                // SI NO SE ESTÁ AUTORIZADO ...
                if (response_.StatusCode == System.Net.HttpStatusCode.Unauthorized) // 401
                {
                    throw new Exception("401 Unauthorized. Usuario No autorizado. " +
                        responseText_);

                }
                else
                // CUALQUIER OTRA RESPUESTA ...
                if (response_.StatusCode != System.Net.HttpStatusCode.OK && // 200
                    response_.StatusCode != System.Net.HttpStatusCode.NoContent) // 204
                {
                    // var responseBody_ = JsonConvert.DeserializeObject<object>(responseText_);
                    _responseModel.Code = "200";
                    _responseModel.Data = responseText_;
                    // throw new Exception((int)response_.StatusCode + ". No se esperaba el código de estado HTTP de la respuesta. " + responseText_);
                }

            }

            return default(ResponseModel);
        }

        public async Task<T> Execute<T>(Enum EnumMethod, string Path, dynamic Data) where T : new()
        {
            ResponseModel _responseModel = new ResponseModel();
            string Token = "";

            using (var _request = new HttpRequestMessage())
            {
                _request.Content = new StringContent(JsonConvert.SerializeObject(Data));
                _request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                _request.Method = new HttpMethod(EnumMethod.ToString());
                _request.RequestUri = new Uri(this.Configuration["Api:Url"] + Path, System.UriKind.RelativeOrAbsolute);
                _request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                _request.Headers.Add("Authorization", "Bearer "+ this.HttpContextAccessor.HttpContext.Session.GetString("Token"));//Aqui se agrega el token
                //_usersessionservice.GetToken());

                var response_ = await _client.SendAsync(_request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

                // OBTENEMOS EL Content DEL RESPONSE como un String
                // Utilizamos ConfigureAwait(false) para evitar el DeadLock.
                var responseText_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);

                // SI ES LA RESPUESTA ESPERADA !! ...
                if (response_.StatusCode == System.Net.HttpStatusCode.OK) // 200
                {
                    // DESERIALIZAMOS Content DEL RESPONSE
                    var responseBody_ = JsonConvert.DeserializeObject<T>(responseText_);
                    return responseBody_;
                }
                else
                //InternalServerError
                if (response_.StatusCode == System.Net.HttpStatusCode.InternalServerError) // 500
                {
                    // InternalServerError
                    // throw new Exception("500 InternalServerError. Las credenciales de acceso del usuario son incorrectas. " + responseText_);
                    _responseModel.Code = "500";
                    _responseModel.Message = JsonConvert.DeserializeObject<object>(responseText_).ToString();
                }
                // SI NO SE ESTÁ AUTORIZADO ...
                if (response_.StatusCode == System.Net.HttpStatusCode.Unauthorized) // 401
                {
                    throw new Exception("401 Unauthorized. Usuario No autorizado. " +
                        responseText_);
                }
                else
                // CUALQUIER OTRA RESPUESTA ...
                if (response_.StatusCode != System.Net.HttpStatusCode.OK && // 200
                    response_.StatusCode != System.Net.HttpStatusCode.NoContent) // 204
                {
                    // var responseBody_ = JsonConvert.DeserializeObject<object>(responseText_);
                    _responseModel.Code = "200";
                    _responseModel.Data = responseText_;
                    // throw new Exception((int)response_.StatusCode + ". No se esperaba el código de estado HTTP de la respuesta. " + responseText_);
                }

            }

            return default(T);

            // dynamic item = new T();
            // return item;
        }

        public async Task<(T, string, string)> ExecuteAPI<T>(Enum EnumMethod, string Path, dynamic DataModel) where T : new()
        {
            StringBuilder sbMessage = new StringBuilder();

            using (var _request = new HttpRequestMessage())
            {
                _request.Content = new StringContent(JsonConvert.SerializeObject(DataModel));
                _request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                _request.Method = new HttpMethod(EnumMethod.ToString());
                _request.RequestUri = new Uri(this.Configuration["Api:Url"] + Path, System.UriKind.RelativeOrAbsolute);
                _request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                _request.Headers.Add("Authorization", "Bearer "+ this.HttpContextAccessor.HttpContext.Session.GetString("Token"));//Aqui se agrega el token

                var response_ = await _client.SendAsync(_request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

                // OBTENEMOS EL Content DEL RESPONSE como un String
                var responseText_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);

                // SI ES LA RESPUESTA ESPERADA !! ...
                if (response_.StatusCode == System.Net.HttpStatusCode.OK) // 200
                {
                    string msgSucess = string.Empty;
                    if (EnumMethod.ToString() == "PUT")
                    {
                        msgSucess = "El registro ha sido actualizado correctamente.";
                    }
                    else if (EnumMethod.ToString() == "POST")
                    {
                        msgSucess = "El registro ha sido creado correctamente.";
                    }
                    else if (EnumMethod.ToString() == "DELETE")
                    {
                        msgSucess = "El registro ha sido eliminado correctamente.";
                    }
                    // DESERIALIZAMOS Content DEL RESPONSE
                    return (JsonConvert.DeserializeObject<T>(responseText_), msgSucess, sbMessage.ToString());
                }
                else  //InternalServerError
                if (response_.StatusCode == System.Net.HttpStatusCode.InternalServerError) // 500
                {
                    sbMessage.Append(JObject.Parse(responseText_)["error"].ToString());
                }
                else  //InternalServerError
                if (response_.StatusCode == System.Net.HttpStatusCode.BadRequest) // 500
                {
                    sbMessage.Append(JObject.Parse(responseText_)["error"].ToString());
                }
                // SI NO SE ESTÁ AUTORIZADO ...
                if (response_.StatusCode == System.Net.HttpStatusCode.Unauthorized) // 401
                {
                    sbMessage.Append("401 Unauthorized. Usuario No autorizado. " + responseText_);
                }
                else // CUALQUIER OTRA RESPUESTA ...
                if (response_.StatusCode != System.Net.HttpStatusCode.OK && // 200
                    response_.StatusCode != System.Net.HttpStatusCode.NoContent) // 204
                {
                    // sbMessage.Append(responseText_);
                }

                return (new T(), string.Empty, sbMessage.ToString());
            }
        }

    }
}
