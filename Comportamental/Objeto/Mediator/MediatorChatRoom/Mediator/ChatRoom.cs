namespace MediatorExample.Mediator;

/// <summary>
/// ConcreteMediator: Implementa a interface de mediador e coordena a comunicação entre os usuários.
/// </summary>
public class ChatRoom : IChatRoom
{
    private List<User> _users = new List<User>();

    /// <summary>
    /// Registra um usuário no mediador.
    /// </summary>
    /// <param name="user">Usuário a ser registrado.</param>
    public void Register(User user)
    {
        _users.Add(user);
    }

    /// <summary>
    /// Envia uma mensagem para todos os usuários, exceto o remetente.
    /// </summary>
    /// <param name="message">Mensagem a ser enviada.</param>
    /// <param name="sender">Remetente da mensagem.</param>
    public void Send(string message, User sender)
    {
        foreach (User user in _users)
        {
            if (user != sender)
            {
                user.Receive(message);
            }
        }
    }
}