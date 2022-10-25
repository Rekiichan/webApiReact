namespace webAPI
{
  public class Startup
  {
    IConfiguration configuration { get; }

    public Startup(IConfiguration _configuration)
    {
      configuration = _configuration;
    }
    public void ConfigureServices(IServiceCollection _services)
    {
        
    }
  }
}
