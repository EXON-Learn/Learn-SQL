# Learn-SQL
SQL 배우기

## 주의 사항
- 필자는 MySQL 을 사용한다

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

## delete <br>
MySQL에서는 DELETE 문을 사용하여 테이블의 레코드를 삭제할 수 있습니다. <br>

### 형식 <br>
DELETE FROM 테이블이름 WHERE 필드이름=데이터값; <br>
DELETE 문은 해당 테이블에서 WHERE 절의 조건을 만족하는 레코드만을 삭제합니다. <br>
즉, 테이블에서 명시된 필드와, 그 값이 일치하는 레코드만을 삭제해 줍니다. <br>
만약 WHERE 절을 생략하면, 해당 테이블에 저장된 모든 데이터가 삭제됩니다. <br>
<br>
DELETE FROM 테이블이름; <br>
<br>
이때 테이블에 저장된 모든 데이터가 삭제되더라도 테이블은 여전히 남아있게 됩니다. <br>
해당 테이블까지 삭제하고 싶을 때는 DROP TABLE 문을 사용해야 합니다. <br>
<br>
다음 예제는 Reservation 테이블에서 Name 필드의 값이 '홍길동'인 모든 레코드를 삭제하는 예제입니다. <br>
<br>
### 예제
DELETE FROM Reservation WHERE Name = '홍길동';



