﻿using System;

namespace PipelineSpace.Worker.Host.DI
{
    /// <summary>
    /// Defines the interface of builder that creates an instance of an <see cref="IServiceProvider"/>.
    /// </summary>
    public interface IServiceProviderBuilder
    {
        /// <summary>
        /// Creates an instance of an <see cref="IServiceProvider"/>.
        /// </summary>
        /// <returns></returns>
        IServiceProvider Build();
    }
}
