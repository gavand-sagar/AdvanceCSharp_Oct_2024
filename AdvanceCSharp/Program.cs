abstract class Person {
        public abstract void run();
}




abstract class Network {

    public abstract void connectToWifi(string ssid,string passkey);

    public void accessGoogle()
    {
        connectToWifi("MyHome", "MyHom@123");

    }
    
}


abstract class studentBase {

    protected abstract void dance();
    public abstract void sing();

    public void act()
    {
        dance();
        sing();
    }
}



abstract class orderbase
{
    public abstract string cardInfo { get; set; }

    public string getCardInfo()
    {
        return "";
    }

    public void setCardInfo(string value)
    {
      
    }




    public abstract bool payment();
    public void order(object product)
    {
        payment();
        placeOrderForProduct(product);
    }

    private void placeOrderForProduct(object product)
    {
        throw new NotImplementedException();
    }
}










class UpIOrder : orderbase
{
    public override string cardInfo { get => "my casrd"; set => throw new NotImplementedException(); }

    public override bool payment()
    {
        throw new NotImplementedException();
    }
}


class CreditCardBaedOrder : orderbase
{
    public override string cardInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override bool payment()
    {
        throw new NotImplementedException();
    }
}



