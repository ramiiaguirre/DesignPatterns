public abstract class Creator
{
    public abstract IProduct FactoryMethod();


    public string SomeOperation()
    {
        var product = FactoryMethod();
        var result = "Creator's code: "
            + product.Operation();

        return result;
    }
}

    