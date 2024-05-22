namespace CalculadoraSalario.Tests;

public class CalculadoraSalarioTest
{
    [Fact]
    public void Should_Pay_5_Parcent_INSS_Tax()
    {
        CalculadoraSalario calculadoraSalario = new CalculadoraSalario();

        double salarioBruto = 800;

        double inss = calculadoraSalario.GetDescontoInss(salarioBruto);
        double desconto = 40.0;

        Assert.Equal(desconto, inss);

       
    }

    [Fact]
    public void Should_Throw_Eception_When_Brute_Salary_Is_Negative()
    {
        CalculadoraSalario calculadoraSalario = new CalculadoraSalario();
        double salarioNegativo = -400.0;

        Assert.Throws<Exception>(() => calculadoraSalario.
        GetDescontoInss(salarioNegativo));



    }

    [Fact]
    public void Should_Pay_10_Percent_INSS_Tax()
    {
        CalculadoraSalario calculadoraSalario = new CalculadoraSalario();

        double salarioBruto = 11000.00;
        double inss = calculadoraSalario.GetDescontoInss(salarioBruto);
        double desconto = 1100.00;

        Assert.Equal(desconto, inss);

    }

    [Fact]
    public void Should_pay_Ir_Low_1000()
    {
        CalculadoraSalario calculadora = new CalculadoraSalario();
        double bruto = 600;

        double ir = calculadora.getDescontoIr(bruto);
        double desconto = 0.0;

        Assert.Equal(desconto, ir);
    }

    [Fact]
    public void Should_pay_Ir_Between_1000_And_3000()
    {
        CalculadoraSalario calculadora = new CalculadoraSalario();
        double bruto = 2000;

        double ir = calculadora.getDescontoIr(bruto);
        double desconto = 200.0;

        Assert.Equal(desconto, ir);
    }

    [Fact]
    public void Should_pay_Ir_Above_3000()
    {
        CalculadoraSalario calculadora = new CalculadoraSalario();
        double bruto = 4000;

        double ir = calculadora.getDescontoIr(bruto);
        double desconto = 800.0;

        Assert.Equal(desconto, ir);
    }
}