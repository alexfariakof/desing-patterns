namespace MediatorExample.Mediator;

/// <summary>
/// ConcreteColleague: Implementa um usuário específico que interage com outros usuários por meio do mediador.
/// </summary>
public class ChatUser : User
{
    /// <summary>
    /// Construtor que recebe uma instância de IChatRoom para associação com o mediador.
    /// </summary>
    /// <param name="chatRoom">Instância de IChatRoom utilizada como mediador.</param>
    public ChatUser(IChatRoom chatRoom) : base(chatRoom) { }

    /// <summary>
    /// Envia uma mensagem para o mediador (IChatRoom).
    /// </summary>
    /// <param name="message">Mensagem a ser enviada.</param>
    public override void Send(string message)
    {
        Console.WriteLine("User sends message: " + message);
        _chatRoom.Send(message, this);
    }

    /// <summary>
    /// Recebe uma mensagem do mediador (IChatRoom).
    /// </summary>
    /// <param name="message">Mensagem recebida.</param>
    public override void Receive(string message)
    {
        Console.WriteLine("User receives message: " + message);
    }
}