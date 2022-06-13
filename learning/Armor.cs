using System;

namespace learning {
	public class Armor {
        public int defence { get; }
        public string name { get; }

		public Armor(int defence, string name) {
			this.defence = defence;
			this.name = name;
		}
	}
}

