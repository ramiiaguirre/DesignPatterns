class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ProductB();
    }
}