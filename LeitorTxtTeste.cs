using System;
using NUnit.Framework;

[TestFixture]
public class TestAnimalShelter
{
    [SetUp]
    public void RunBeforeAnyTests()
    {
        
    }

    [Test]
    public void LerTxtTeste()
    { 
        //given
        string path = @"D:\Google Drive\Trabalho\Estudar\Bankrupt\gameConfig.txt";
        LeitorTxt leitor = new LeitorTxt(path);
        leitor.CarregarArquivo();
        //when
        //var ex = Assert.Throws<ArgumentOutOfRangeException>(()=>larFeliz.PickOne("cat"));
        //then
        //Assert.AreEqual("fila de gatos vazia", ex.Message);
    }

    [Test]
    public void ShouldReturnExceptionWhenNoCat()
    { 
        //given
        //when
        //var ex = Assert.Throws<ArgumentOutOfRangeException>(()=>larFeliz.PickOne("cat"));
        //then
        //Assert.AreEqual("fila de gatos vazia", ex.Message);
    }
       
}