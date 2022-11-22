create database atosframe

create login atosframe with password='atosframe';
create user atosframe from login atosframe;

exec sp_addrolemember 'DB_DATAREADER', 'atosframe';
exec sp_addrolemember 'DB_DATAWRITER', 'atosframe';

select *
from Pessoas

select *
from Emails
