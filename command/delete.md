## delete : 데이터 삭제<br>
MySQL에서는 DELETE 문을 사용하여 테이블의 레코드를 삭제할 수 있습니다. <br>

### 형식 <br>s
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

