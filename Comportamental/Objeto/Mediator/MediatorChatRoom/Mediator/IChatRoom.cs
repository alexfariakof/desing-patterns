namespace MediatorExample.Mediator;

/// <summary>
/// Interface Mediator: Define um contrato para o mediador que facilita a comunicação entre os colegas (usuários).
/// </summary>
public interface IChatRoom
{
    /// <summary>
    /// Registra um usuário no mediador.
    /// </summary>
    /// <param name="user">Usuário a ser registrado.</param>
    void Register(User user);

    /// <summary>
    /// Envia uma mensagem para todos os usuários, exceto o remetente.
    /// </summary>
    /// <param name="message">Mensagem a ser enviada.</param>
    /// <param name="user">Remetente da mensagem.</param>
    void Send(string message, User user);
}