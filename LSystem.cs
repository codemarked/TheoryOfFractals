namespace FractalTheory
{
    public class LSystem
    {
        public List<char> variables;
        public List<Rule> rules;
        public string start;
        public float angle;
        public int iterations;

        public LSystem() { }

        public void Init()
        {

            this.variables = new List<char> { 'F', 'G' };
            this.start = "F-G-G";
            this.rules = new List<Rule>() { new('F', "F−G+F+G−F"), new('G', "GG") };
            this.angle = 120f;
        }

        public class Rule
        {
            public char variable;
            public string value;

            public Rule(char variable, string value)
            {
                this.variable = variable;
                this.value = value;
            }

            public override string ToString()
            {
                return variable + " " + value;
            }
        }

        public Rule getRule(char variable)
        {
            foreach (Rule rule in rules)
                if (rule.variable == variable)
                    return rule;
            return null;
        }

        public string Iterate()
        {
            string system = this.start;
            for (int i = 0; i < iterations; i++)
            {
                var result = system.SelectMany(c => {
                    Rule rule = getRule(c);
                    if (rule == null)
                        return c.ToString();
                    return rule.value;
                });
                system = new string(result.ToArray());
            }
            return system;
        }
    }
}
