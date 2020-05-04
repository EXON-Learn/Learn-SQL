## select : 데이터 조회
### 형식 <br>
select 테이블명 from 테이블명; : **일반조회** <br>
select 조회할 컬럼명 from 테이블명 where 조건컬럼명 = 조건데이터; : **조건조회** <br>
select 조회할 컬럼명 from 테이블명 where 조건 and 조건; : **다중조건조회** <br>
<br> 

### 예 <br>
select * from person; : person 테이블의 모든 데이터 조회 <br>
select * from person where age=24; : person의 데이터중 age의 값이 24인 데이터만 조회<br>
select name from person where gender='남'; : person의 데이터 중 gender의 값이 '남'인 데이터의 name 값 조회<br>
select name, age from person where gender='남' and age>20;: person의 데이터 중 gender의 값이 '남'이면서 age가 20이상 데이터의 name, age 값 조회<br>
<br>