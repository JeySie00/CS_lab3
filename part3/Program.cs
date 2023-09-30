class Currency
{
    public double Value { get; set; }
}

class CurrencyUSD : Currency
{
    public CurrencyUSD() { this.Value = base.Value; }
    public static implicit operator CurrencyUSD(CurrencyEUR old) { return new CurrencyUSD { Value = old.Value * 5 }; }
    public static implicit operator CurrencyUSD(CurrencyRUB old) { return new CurrencyUSD { Value = old.Value * 6 }; }
    public static explicit operator CurrencyEUR(CurrencyUSD old) { return new CurrencyEUR { Value = old.Value / 5 }; }
    public static explicit operator CurrencyRUB(CurrencyUSD old) { return new CurrencyRUB { Value = old.Value / 6 }; }
}

class CurrencyEUR : Currency
{
    public CurrencyEUR() { this.Value = base.Value; }
    public static implicit operator CurrencyEUR(CurrencyUSD old) { return new CurrencyEUR { Value = old.Value * 3 }; }
    public static implicit operator CurrencyEUR(CurrencyRUB old) { return new CurrencyEUR { Value = old.Value * 4 }; }
    public static explicit operator CurrencyUSD(CurrencyEUR old) { return new CurrencyUSD { Value = old.Value / 3 }; }
    public static explicit operator CurrencyRUB(CurrencyEUR old) { return new CurrencyRUB { Value = old.Value / 4 }; }
}

class CurrencyRUB : Currency
{
    public CurrencyRUB() { this.Value = base.Value; }
    public static implicit operator CurrencyRUB(CurrencyUSD old) { return new CurrencyRUB { Value = old.Value * 100 }; }
    public static implicit operator CurrencyRUB(CurrencyEUR old) { return new CurrencyRUB { Value = old.Value * 120 }; }
    public static explicit operator CurrencyUSD(CurrencyRUB old) { return new CurrencyUSD { Value = old.Value / 100 }; }
    public static explicit operator CurrencyEUR(CurrencyRUB old) { return new CurrencyEUR { Value = old.Value / 120 }; }
}