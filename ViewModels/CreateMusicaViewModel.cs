﻿using Flunt.Notifications;
using Flunt.Validations;

namespace APIMusicamin.ViewModels
{
    public class CreateMusicaViewModel : Notifiable<Notification>
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }

        public Musica MapTo()
        {
            var contract = new Contract<Notification>()
                .Requires()
                .IsNotNull(Titulo, "Informe o título da música")
                .IsNotNull(Artista, "Informe o artista da música")
                .IsGreaterThan(Titulo, 5, "O título deve conter...");

            AddNotifications(contract);

            return new Musica(Guid.NewGuid(), Titulo, Artista);
        }
    }
}
