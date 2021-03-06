﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.FileSystem.Abstractions;
using RetriX.Shared.Models;
using RetriX.Shared.ViewModels;

namespace RetriX.Shared.Services
{
    public interface IGameSystemsProviderService
    {
        IEnumerable<GameSystemViewModel> Systems { get; }

        Task<IReadOnlyList<GameSystemViewModel>> GetCompatibleSystems(IFileInfo file);
        Task<Tuple<GameLaunchEnvironment, GameLaunchEnvironment.GenerateResult>> GenerateGameLaunchEnvironmentAsync(GameSystemViewModel system, IFileInfo file, IDirectoryInfo rootFolder);
    }
}