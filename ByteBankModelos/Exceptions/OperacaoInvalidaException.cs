namespace ByteBankModelos.Exceptions;


[Serializable]
public class OperacaoInvalidaException : Exception
{
	public OperacaoInvalidaException() { }
	public OperacaoInvalidaException(string message) : base(message) { }
	public OperacaoInvalidaException(string message, Exception inner) : base(message, inner) { }
	protected OperacaoInvalidaException(
	  System.Runtime.Serialization.SerializationInfo info,
	  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
