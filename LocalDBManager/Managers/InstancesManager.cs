namespace LocalDBManager
{
    using MartinCostello.SqlLocalDb;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IInstancesManager : IDisposable
    {
        IReadOnlyList<ISqlLocalDbInstanceInfo> GetInstances();

        void Start(ISqlLocalDbInstanceInfo instanceInfo);

        void Start(string instanceName);

        void Stop(ISqlLocalDbInstanceInfo instanceInfo);
        
        void Stop(string instanceName);

        void Unshare(ISqlLocalDbInstanceInfo instanceInfo);

        void Unshare(string instanceName);

        void Restart(ISqlLocalDbInstanceInfo instanceInfo);

        void Restart(string instanceName);

        void Delete(ISqlLocalDbInstanceInfo instanceInfo, bool deleteFiles);

        void Delete(string instanceName, bool deleteFiles);

        void New(string name);
    }

    public class InstancesManager : IInstancesManager
    {
        readonly SqlLocalDbApi _sqlLocalDbApi;

        public InstancesManager()
        {
            _sqlLocalDbApi = new SqlLocalDbApi();
        }

        public void Dispose()
        {
            _sqlLocalDbApi.Dispose();
        }

        public IReadOnlyList<ISqlLocalDbInstanceInfo> GetInstances()
        {
            return _sqlLocalDbApi.GetInstances();
        }

        public void Start(ISqlLocalDbInstanceInfo instanceInfo)
        {
            instanceInfo.Manage().Start();
        }

        public void Start(string instanceName)
        {
            _sqlLocalDbApi.GetInstanceInfo(instanceName).Manage().Start();
        }

        public void Stop(ISqlLocalDbInstanceInfo instanceInfo)
        {
            instanceInfo.Manage().Stop();
        }

        public void Stop(string instanceName)
        {
            _sqlLocalDbApi.GetInstanceInfo(instanceName).Manage().Stop();
        }

        public void Unshare(ISqlLocalDbInstanceInfo instanceInfo)
        {
            instanceInfo.Manage().Unshare();
        }

        public void Unshare(string instanceName)
        {
            _sqlLocalDbApi.GetInstanceInfo(instanceName).Manage().Unshare();
        }

        public void Restart(ISqlLocalDbInstanceInfo instanceInfo)
        {
            instanceInfo.Manage().Restart();
        }

        public void Restart(string instanceName)
        {
            _sqlLocalDbApi.GetInstanceInfo(instanceName).Manage().Restart();
        }

        public void Delete(ISqlLocalDbInstanceInfo instanceInfo, bool deleteFiles)
        {
            _sqlLocalDbApi.DeleteInstance(instanceInfo.Name, deleteFiles);
        }

        public void Delete(string instanceName, bool deleteFiles)
        {
            _sqlLocalDbApi.DeleteInstance(instanceName, deleteFiles);
        }

        public void New(string name)
        {
            if (_sqlLocalDbApi.GetInstances().FirstOrDefault(instance => instance.Name == name) != null)
            {
                throw new ArgumentException($"There is already an instance named {name}.");
            }
            _sqlLocalDbApi.CreateInstance(name);
        }
    }
}
