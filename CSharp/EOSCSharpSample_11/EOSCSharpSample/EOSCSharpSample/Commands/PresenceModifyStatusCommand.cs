﻿// Copyright Epic Games, Inc. All Rights Reserved.

using EOSCSharpSample.Helpers;
using EOSCSharpSample.Services;
using EOSCSharpSample.ViewModels;

namespace EOSCSharpSample.Commands
{
    public class PresenceModifyStatusCommand : CommandBase
    {
        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrWhiteSpace(ViewModelLocator.Presence.ProductIdText);
        }

        public override void Execute(object parameter)
        {
            PresenceService.ModifyStatus();
        }
    }
}
