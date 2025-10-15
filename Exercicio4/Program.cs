// Sistema de Notificações
using Exercicio4;

Notification[] notifications = new Notification[3];

notifications[0] = new Email();
notifications[1] = new SMS();
notifications[2]  = new PushNotification();

foreach (var notification in notifications)
{
    notification.Send("Hey! Listen! Make sure you stay hydrated!");
    Console.WriteLine();
}