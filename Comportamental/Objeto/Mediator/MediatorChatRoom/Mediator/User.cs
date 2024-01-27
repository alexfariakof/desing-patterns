namespace MediatorExample.Mediator;

/// <summary>
/// Colleague: Define uma interface para os objetos que se comunicam por meio do mediador (IChatRoom).
/// </summary>
public abstract class User
{
    /// <summary>
    /// Referência ao mediador utilizado para comunicação entre usuários.
    /// </summary>
    protected IChatRoom _chatRoom;

    /// <summary>
    /// Construtor que recebe uma instância de IChatRoom para associação com o mediador.
    /// </summary>
    /// <param name="chatRoom">Instância de IChatRoom utilizada como mediador.</param>
    public User(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
    }

    /// <summary>
    /// Método abstrato para enviar uma mensagem através do mediador.
    /// </summary>
    /// <param name="message">Mensagem a ser enviada.</param>
    public abstract void Send(string message);

    /// <summary>
    /// Método abstrato para receber uma mensagem do mediador.
    /// </summary>
    /// <param name="message">Mensagem recebida.</param>
    public abstract void Receive(string message);
}