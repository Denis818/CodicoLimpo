namespace CleanCodeApi.Interfaces
{
    public interface INotificadorErrosServices
    {
        List<string> ListErros { get; set; }
        void NotificarError(string mensagemErro);
        void LimparLista();

        public bool TemNotificacao();
    }
}
