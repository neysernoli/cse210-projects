public class Password
{
  private string _password;
    public void SetThePassword(string password)
    {
      _password = password;
    }

    public bool CheckPassword(string password)
    {
      return _password == password;
    }
}