using PhotonContainer.Business.Interfaces;

namespace PhotonContainer.Business.DIContainers
{
    public class PhotonDIContainer : IContainers
    {
        #region Fields
        private readonly Dictionary<Type, Type> _registrations = new();
        #endregion

        #region Public Methods
        public void Register<TService, TImplementation>() where TImplementation : TService =>
            _registrations[typeof(TService)] = typeof(TImplementation);

        public TService Resolve<TService>() =>
            (TService)Resolve(typeof(TService));
        #endregion

        #region Private Methods
        private object Resolve(Type serviceType)
        {
            if (!_registrations.ContainsKey(serviceType))
                throw new Exception($"Service of type {serviceType.Name} is not registered.");

            Type implementationType = _registrations[serviceType];
            object[] parameterInstances = implementationType.GetConstructors().First().GetParameters()
                .Select(param => Resolve(param.ParameterType))
                .ToArray();

            return Activator.CreateInstance(implementationType, parameterInstances);
        }
        #endregion
    }
}