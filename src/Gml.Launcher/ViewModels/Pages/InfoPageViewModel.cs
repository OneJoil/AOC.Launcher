using System;
using System.Diagnostics;
using System.Reactive.Concurrency;
using Gml.Client;
using Gml.Client.Models;
using Gml.Launcher.Assets;
using Gml.Launcher.Core.Services;
using Gml.Launcher.ViewModels.Base;
using Gml.Web.Api.Domains.Integrations;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Sentry;

namespace Gml.Launcher.ViewModels.Pages;

public class InfoPageViewModel : PageViewModelBase
{
    internal InfoPageViewModel(
        IScreen screen,
        ILocalizationService? localizationService = null) : base(screen,
        localizationService)
    {
    }
}
