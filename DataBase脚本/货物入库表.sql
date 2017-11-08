create table inbank
(
sno char(20),                    --货物编号
sname char(20),                  --货物名称
sprice  float,					 --货物单价
规格  char(10),					 --货物规格
sinnumber int,                   --货物入库数量
sindate char(20),                --货物入库日期
principal char(20),              --仓库负责人
buyer char(20)					 --采购员
)                