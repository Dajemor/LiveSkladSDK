using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using LiveSkladSDK.LiveSkladModels;
using LiveSkladSDK.RequestModel;

namespace LiveSkladSDK
{
    public class LiveSklad
    {
        private LoginData loginData;

        private TokenData token;
        private string host = "https://api.livesklad.com";
        public LiveSklad(LoginData loginData)
        {
            this.loginData = loginData;
        }
        private async Task<RES> request<REQ,RES>(MethodEnum method, string path, REQ? query, object? body = null, Dictionary<string, string>? header = null, bool addToken = true) where RES : class
        {
            
            header = header ?? new Dictionary<string, string>();
            body = body ?? new Dictionary<string, string>();
            if (addToken)
            {
                await RefreshToken();

                header.Add("Authorization", token.Token);
            }
            using (HttpClient client = new HttpClient())
            {
                RES res = null;
                foreach (var head in header)
                {
                    client.DefaultRequestHeaders.Add(head.Key, head.Value);
                }


                var queryParams = query.ToQueryString();

#if DEBUG
                Console.WriteLine(host + path + "?" + queryParams);
#endif
                ByteArrayContent data = null;
                if (body is Dictionary<string, string>)
                {
                 var value = (Dictionary<string, string>)body; 
                  data = new FormUrlEncodedContent(value); 
                }
                else
                {
                    
                 var json = JsonSerializer.Serialize(body, body.GetType(),new JsonSerializerOptions(){ DefaultIgnoreCondition= JsonIgnoreCondition.WhenWritingNull });
                 data = new StringContent(json, Encoding.UTF8, "application/json");   
                }
                HttpResponseMessage response = null;
                if (method == MethodEnum.GET)
                {
                     response = await client.GetAsync(host + path + "?" + queryParams);
                }
                if (method == MethodEnum.POST)
                {
                     response = await client.PostAsync(host + path + "?" + queryParams, data);
                }

                if (method == MethodEnum.PATCH)
                {
                    response = await client.PatchAsync(host + path + "?" + queryParams, data);
                }

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseText = await response.Content.ReadAsStringAsync();
                    res = JsonSerializer.Deserialize<RES>(responseText);
                }
                else
                {

                    Console.WriteLine(response.StatusCode);
                    var error = JsonSerializer.Deserialize<ErrorRoot>(await response.Content.ReadAsStringAsync());
                    Console.WriteLine(error.Error.Message);
                }
                return res;
            }

        }
        private async Task RefreshToken()
        {
            if (this.token == null || this.token.Create_token.AddMinutes(10) < DateTime.Now)
            {
                this.token = await GetToken();
            }
        }
        public async Task<TokenData> GetToken()
        {
            var con = new Dictionary<string, string>() { { "login", loginData.login }, { "password", loginData.password } };
            TokenRS responseToken = await this.request<NoQuery,TokenRS>(MethodEnum.POST, "/auth", null, loginData, null, false);
            return new TokenData() { Create_token = DateTime.Now, Token = responseToken.Token };
        }

        public async Task<LSRoot<LSOrders>> GetOrders(OrderFilter? orderFilter=null)
        {
           
            return await this.request<OrderFilter, LSRoot<LSOrders>>(MethodEnum.GET, "/company/orders", orderFilter, null, null, true);
        }

        public async Task<SingleRoot<SingleOrder>> GetOrder(string orderid)
        {
            return await this.request<OrderFilter, SingleRoot<SingleOrder>>(MethodEnum.GET, $"/orders/{orderid}", null, null, null, true);
        }
       
        public async Task<LSRoot<LSOrders>> GetOrders(bool allpages,OrderFilter? orderFilter = null)
        {
            orderFilter= orderFilter?? new OrderFilter();
            orderFilter.page = 1;
            orderFilter.pageSize = 50;
            var rootorder = await GetOrders(orderFilter);
            if (rootorder!=null)
            if (allpages)
            {
                var i = 2;
                while (rootorder.Total > rootorder.Data.Count)
                {
                    orderFilter.page = i;
                    var rootordernew = await GetOrders(orderFilter);
                    rootorder.Data.AddRange(rootordernew.Data);
                    i++;
                }
            }
            return rootorder;
        }

        public async Task<LSRoot<Counteragent>> GetClient(ClientFilter? clientFilter = null)
        {
            return await this.request<ClientFilter, LSRoot<Counteragent>>(MethodEnum.GET, "/counteragents", clientFilter, null, null, true);
        }
        public async Task<SingleRoot<Counteragent>> CreateClient(ClientCreateModel clientModel )
        {
            return await this.request<NoQuery, SingleRoot<Counteragent>>(MethodEnum.POST, "/counteragents", null, clientModel,null, true);
        }
        public async Task<LSRoot<TypeCounteragents>> GetTypeCounteragents()
        {
            return await this.request<NoQuery, LSRoot<TypeCounteragents>>(MethodEnum.GET, "/type-counteragents", null, null, null, true);
        }
        public async Task<SingleRoot<Ids>> CreateOrder( string idbranch, OrderCreateModel ordermModel)
        {
            return await this.request<NoQuery, SingleRoot <Ids>> (MethodEnum.POST, $"/shops/{idbranch}/orders", null, ordermModel, null, true);
        }
        public async Task<SingleRoot<SuccessModel>> UpdateOrder(string orderid, OrderUpdateModel ordermModel)
        {
            return await this.request<NoQuery, SingleRoot<SuccessModel>>(MethodEnum.PATCH, $"/orders/{orderid}", null, ordermModel, null, true);
        }
        public async Task<LSRoot<Branch>> GetBranch()
        {
            return await this.request<NoQuery, LSRoot<Branch>>(MethodEnum.GET, $"/shops", null, null, null, true);
        }
        public async Task<LSRoot<OrderType>> GetOrderType()
        {
            return await this.request<NoQuery, LSRoot<OrderType>>(MethodEnum.GET, $"/type-orders", null, null, null, true);
        }
        public async Task<SingleRoot<StatusData>> GetStatuses()
        {
            return await this.request<NoQuery, SingleRoot<StatusData>>(MethodEnum.GET, $"/statuses", null, null, null, true);
        }
    }
}