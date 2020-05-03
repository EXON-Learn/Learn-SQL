# Learn-SQL
SQL 배우기

## SQL 이란?
SQL은 관계형 데이터베이스 관리 시스템(RDBMS)의 데이터를 관리하기 위해 설계된 특수 목적의 프로그래밍 언어이다. <br>
관계형 데이터 베이스 관리 시스템에서 자료의 검색과 관리, 데이터베이스 스키마 생성과 수정, <br>
데이터 베이스 객체 접근 조정 관리를 위해 고안되었다. <br>
많은 수의 데이터베이스 관련 프로그램들이 SQL을 표준으로 채택하고 있다. <br>
\[위키디피아\]

## desc : 테이블 구조
<img src="/desc.png"> <br>

### 형식 <br>
desc 테이블이름; <br>
<br>

<b> 예 </b> <br>
decs person; <br>

## insert : 삽입
### 형식 <br>
insert into 테이블이름(컬럼 이름) values(데이터); <br>
<br>

### 예 <br>
insert into person(name, age, gender, grade) values('YoWu', '24', '남', '3'); <br>
특정 컬럼에만 값을 넣을 경우 컬럼 이름을 넣어주면 된다. 컬럼명 미기재시 모든 컬럼에 순차적으로 데이터가 입력된다. <br>

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



