using System.Threading.Tasks;
using Microsoft.JSInterop;

public class JsAuthService
{
    private readonly IJSRuntime _js;
    public JsAuthService(IJSRuntime js) => _js = js;

    public ValueTask SetTokenAsync(string token) => _js.InvokeVoidAsync("auth.setToken", token);
    public ValueTask<string> GetTokenAsync() => _js.InvokeAsync<string>("auth.getToken");
    public ValueTask RemoveTokenAsync() => _js.InvokeVoidAsync("auth.removeToken");
}
