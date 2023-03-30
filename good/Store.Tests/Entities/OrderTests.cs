namespace Store.Tests.Entities;
using Store.Domain.Enums;
using Store.Domain.Entities;

[TestClass]
public class OrderTests
{
   [TestMethod]
   [TestCategory("Domain")]
   public void Dado_um_novo_pedido_valido_ele_deve_gerar_um_numero_com_8_caracteres()
   {
      var pedido = new Order(new Customer("test", "test@gmail.com"), 10, null);
      Assert.AreEqual(8, pedido.Number.Length);
   }

   [TestMethod]
   [TestCategory("Domain")]
   public void Dado_um_novo_pedido_seu_status_deve_ser_aguardando_pagamento()
   {
      Assert.Fail();
   }

   [TestMethod]
   [TestCategory("Domain")]
   public void Dado_um_novo_pedido_seu_status_deve_ser_aguardando_entraga()
   {
      Assert.Fail();
   }

   [TestMethod]
   [TestCategory("Domain")]
   public void Dado_um_novo_pedido_seu_status_deve_ser_cancelado()
   {
      Assert.Fail();
   }

   [TestMethod]
   [TestCategory("Domain")]
   public void Dado_um_novo_pedido_sem_pruduto_o_mesmo_nao_deve_ser_adicionado()
   {
      Assert.Fail();
   }

   [TestMethod]
   [TestCategory("Domain")]
   public void Dado_um_novo_item_com_quantidade_zero_ou_menor_o_mesmo_nao_deve_ser_adicionado()
   {
      Assert.Fail();
   }

   [TestMethod]
   [TestCategory("Domain")]
   public void Dado_um_novo_pedido_seu_total_deve_ser_50()
   {
      Assert.Fail();
   }

   [TestMethod]
   [TestCategory("Domain")]
   public void Dado_um_desconto_expirado_o_valor_do_pedido_deve_ser_60()
   {
      Assert.Fail();
   }

   [TestMethod]
   [TestCategory("Domain")]
   public void Dado_um_desconto_invalido_o_valor_do_pedido_deve_ser_60()
   {
      Assert.Fail();
   }

   [TestMethod]
   [TestCategory("Domain")]
   public void Dado_um_desconto_de_10_seu_valor_do_pedido_deve_ser_50()
   {
      Assert.Fail();
   }
}
