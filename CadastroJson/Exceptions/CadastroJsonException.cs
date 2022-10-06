using System;

namespace _CadastroJson.Exceptions
{
        public class CadastroJsonException : Exception
        {
            public CadastroJsonException() : base()
            {
            
            }

            public CadastroJsonException(string mensagem) : base(mensagem)
            {
            
            }

            public CadastroJsonException(string mensagem, Exception exception) : base(mensagem)
            {
            
            }
        }

      public class DataBaseErrorCadastroJsonException: CadastroJsonException
      {
        public DataBaseErrorCadastroJsonException(string mensagem) : base(mensagem)
        {

        }
    }
}
