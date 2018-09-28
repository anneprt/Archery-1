﻿using Archery.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Archery.Controllers
{
    public abstract class BaseController:Controller
    {
        /// <summary>
        /// Affiche un message dans le layout success ou erreur avec ou sans redirection
        /// </summary>
        /// <param name="text">Le texte à afficher</param>
        /// <param name="type">Le type de message</param>

        protected void Display(string text, MessageType type = MessageType.SUCCESS) //par défaut, c'est le message success donc inutile de préciser dans l'appel
        {
            var m = new Message(type, text);
            TempData["MESSAGE"] = m;
        }
    }
}