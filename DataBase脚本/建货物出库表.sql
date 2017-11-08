create table outbank
(
sno char(20),                    --货物编号
sname char(20),                  --货物名称
sprice  float,					 --货物单价
规格  char(10),					 --货物规格
outdate smalldatetime,           --货物出库日期
soutnumber int,                  --货物出库数量
principal char(20),              --仓库管理员
deliveryman char(20)			 --送货员
)           