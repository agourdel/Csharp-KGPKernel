namespace KGPKernel.Services._ExampleService.Config
{
    public abstract class AbstractExampleDefautConfig
    {
        public virtual int FirstValue { get; protected set; } = 42;
        public virtual String SecondValue { get; protected set; } = "Defaut";
        protected AbstractExampleDefautConfig()
        {
        }
    }
}
