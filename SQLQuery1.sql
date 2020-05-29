select itemvenda.idproduto, produto.descricao, itemvenda.qtde, itemvenda.valorun, itemvenda.valortotal
from cliente
join venda on cliente.id = venda.idcliente
join vendedor on venda.idvendedor = vendedor.id
join itemvenda on itemvenda.idvenda = venda.id 
join produto on itemvenda.idproduto = produto.id
where venda.id = 77