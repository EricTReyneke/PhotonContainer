namespace PhotonContainer.Business.Interfaces
{
    public interface IContainers
    {
        /// <summary>
        /// Registers a service type and its implementation type in the container.
        /// </summary>
        /// <typeparam name="TService">The type of the service to register.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation to register.</typeparam>
        public void Register<TService, TImplementation>() where TImplementation : TService;

        /// <summary>
        /// Resolves an instance of the specified service type.
        /// </summary>
        /// <typeparam name="TService">The type of the service to resolve.</typeparam>
        /// <returns>An instance of the specified service type.</returns>
        /// <exception cref="Exception">Thrown if the service type is not registered.</exception>
        public TService Resolve<TService>();
    }
}