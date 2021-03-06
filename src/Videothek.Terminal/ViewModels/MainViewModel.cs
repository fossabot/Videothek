﻿using System;
using Stylet;
using StyletIoC;
using Videothek.Core;

namespace Videothek.Terminal.ViewModels
{
    public class MainViewModel : Conductor<IScreen>.Collection.OneActive
    {
        private readonly IContainer _container;

        public MainViewModel(IContainer container)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));

            LibraryViewModel = new LibraryViewModel(_container);
        }

        public void ActivateScreen(Screen screen)
        {
            this.ActivateItem(screen);
        }

        public LibraryViewModel LibraryViewModel { get; }
    }
}
