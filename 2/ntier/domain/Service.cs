public class Service(IProvider provider) {
    public string One() {
        var one = provider.One();
        return one.ToString();
    }
}