create table outbank
(
出库单编号 char(30),                    --货物编号
货物名称 char(20),                  --货物名称
货物单价  float,					 --货物单价
规格  char(10),					 --货物规格
出库日期 smalldatetime,           --货物出库日期
出库数量 int,                  --货物出库数量
仓库管理员 char(20),              --仓库管理员
配送员 char(20)			 --送货员
PRIMARY KEY
(
出库单编号,
货物名称
)
)           