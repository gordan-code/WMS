create table stock               --库存表
(
sno char(20)  NOT NULL,          --货物编号
sname char(20),                  --货物名称
snumber int,					 --数量
price float,					 --单价
supplier char(40),				 --供应商
intime smalldatetime,			 --入库时间
specifican char(20),			 --货物规格
备注     char(40)				 --备注
)  