using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class Missile
    {
        private string _name { get; set; }
        private int? _masa { get; set; }
        private int? _speed { get; set; }
        private int ? _time { get; set; }
        private int? _damage { get; set; }

        private Dictionary<string, int> _origin { get; set; }

        private Dictionary <string, int> _angle { get; set; }


        public string getName()
        {
            return this._name;
        }
        public int getMasa()
        {
            return (int)this._masa;
        }
        public int getSpeed()
        {
            return (int)this._speed;
        }
        public int getTime()
        {
            return (int)this._time;
        }
        public int getDamage()
        {
            return (int)this._damage;
        }
        public Dictionary<string, int> getOrigin() 
        {
                return this._origin;
        }
        public Dictionary<string, int> getAngle()
        {
            return this._angle;
        }
        public void setName(string name)
        { 
            this._name = name;
        }
        public void setMasa(int masa)
        {
            this._masa = masa;
        }
        public void setSpeed(int speed)
        {
            this._speed = speed;
        }
        public void setTime(int time)
        {
            this._time = time;
        }
        public void setDamage(int damage)
        {
            this._damage = damage;
        }
        public void setOrigin(Dictionary<string, int> origin)
        {
            this._origin = origin;
        }
        public void setAngle(Dictionary<string, int> angle)
        { 
            this._angle = angle;
        }


    }
}
