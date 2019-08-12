using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }
        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            int result = this.GetStatPower() + this.GetWeaponPower();

            return result;
        }

        public int GetWeaponPower()
        {
            int result = this.Weapon.Solidity + this.Weapon.Sharpness + this.Weapon.Size;

            return result;
        }

        public int GetStatPower()
        {
            int result = this.Stat.Skills + this.Stat.Agility + this.Stat.Flexibility
                         + this.Stat.Intelligence + this.Stat.Strength;

            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name} - {this.GetTotalPower()}");
            sb.AppendLine($"  Weapon Power: {this.GetWeaponPower()}");
            sb.AppendLine($"  Stat Power: {this.GetStatPower()}");

            return sb.ToString().TrimEnd();
        }
    }
} 