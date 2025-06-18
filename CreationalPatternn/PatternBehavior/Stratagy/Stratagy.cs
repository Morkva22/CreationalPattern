using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    public interface IStrategy
    {
        string StartMoving(string name, string bodyPart, string covering);
        string StopMoving(string name, string bodyPart, string covering);
        bool IsMoving(string name);
    }

    public abstract class Strategy : IStrategy
    {
        protected bool isMoving { get; set; } = false;

        public abstract string StartMoving(string name, string bodyPart, string covering);
        public abstract string StopMoving(string name, string bodyPart, string covering);
        public abstract bool IsMoving(string name);
    }

    public class BirdMoveStrategy : Strategy
    {
        public override string StartMoving(string name, string bodyPart, string covering)
        {
            isMoving = true;
            return $"{name} starts flying with {bodyPart} and {covering}";
        }

        public override string StopMoving(string name, string bodyPart, string covering)
        {
            isMoving = false;
            return $"{name} stops flying and lands with {bodyPart}";
        }

        public override bool IsMoving(string name)
        {
            return isMoving;
        }
    }

    public class FishMoveStrategy : Strategy
    {
        public override string StartMoving(string name, string bodyPart, string covering)
        {
            isMoving = true;
            return $"{name} starts swimming with {bodyPart} and {covering}";
        }

        public override string StopMoving(string name, string bodyPart, string covering)
        {
            isMoving = false;
            return $"{name} stops swimming and rests with {bodyPart}";
        }

        public override bool IsMoving(string name)
        {
            return isMoving;
        }
    }

    public class MammalMoveStrategy : Strategy
    {
        public override string StartMoving(string name, string bodyPart, string covering)
        {
            isMoving = true;
            return $"{name} starts running with {bodyPart} and {covering}";
        }

        public override string StopMoving(string name, string bodyPart, string covering)
        {
            isMoving = false;
            return $"{name} stops running and rests with {bodyPart}";
        }

        public override bool IsMoving(string name)
        {
            return isMoving;
        }
    }
}