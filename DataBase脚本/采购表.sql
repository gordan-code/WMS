create table purchase            --采购订单表
(
订单编号 char(10),				 --订单编号
货物名称 char(20),               --货物名称
规格   char(10),		         --货物规格（盒、箱、件等）
供应商 char(20),                  --供应商
单价   float,				     --货物单价
购买数量 int,                    --货物购买数量
采购员 char(20),                 --采购员

)                  