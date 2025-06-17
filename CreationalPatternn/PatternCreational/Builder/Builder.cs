using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Builder
{
    public interface IBuilder<T>
    {
        T InstallCPU();
        T InstallRAM();
        T InstallGPU();
        T InstallStorage();
        T InstallPowerSupply();
        T InstallCooling();
        
        T RemoveCPU();
        T RemoveRAM();
        T RemoveGPU();
        T RemoveStorage();
        T RemovePowerSupply();
        T RemoveCooling();
    }
    
    public abstract class Builder<T> : IBuilder<T>
    {
        protected virtual void GetActionInfo(string action, string component)
        {
            Console.WriteLine($"{action} {component}");
        }
        
        protected Product<T> product { get; set; }
        
        public abstract T InstallCPU();
        public abstract T InstallRAM();
        public abstract T InstallGPU();
        public abstract T InstallStorage();
        public abstract T InstallPowerSupply();
        public abstract T InstallCooling();
        
        public abstract T RemoveCPU();
        public abstract T RemoveRAM();
        public abstract T RemoveGPU();
        public abstract T RemoveStorage();
        public abstract T RemovePowerSupply();
        public abstract T RemoveCooling();
    }
}

