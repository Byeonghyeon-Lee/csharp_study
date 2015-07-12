# csharp_study
github remote repository for C Sharp Study

# README.md 파일에 대해서...
이 `README.md`라는 파일은 파일 이름으로도 아시겠지만, `도움말` 같은 역할을 하는 파일입니다.<br>
공통으로 필요한 공지사항이나 주의사항 등은 이 README.md 파일을 통해 git repository에 방문하는 유저들에게 보여집니다.<br>
확장자인 `.md`는 `markdown`의 약자로, 이처럼 README.md와 같은 텍스트 문서를 작성할 때 주로 사용하는 문법입니다.<br>
자세한 사용법은 구글에서 markdown이라고 검색하면 쉽게 찾으실 수 있으니 참고하시기 바랍니다.

# 이 repository를 local 환경에 clone하는 방법
local 환경에 작업 대상의 git repository를 깃허브나 깃랩과 같은 remote repository로부터 복사해오는것을 `clone`이라고 합니다.<br>
제가 CLI(Command Line Interface)로 밖에 git을 써보지 않아서 부득이하게 명령어 위주로 설명을 하게 될것 같습니다...<br>
GUI를 활용하는 방법에 대해서는 생활코딩 홈페이지에 있는 Git 강의를 참조하시면 될것 같습니다.<br>

우선 이 repository를 clone하기 위해서 필요한 과정이 있습니다.<br>

	1. local 환경에 git 설치하기
	git-scm.com (구글에서 git이라고 검색해도 나옵니다.)에 접속하셔서 깃 인스톨러를 다운받아 설치해주세요.
	그리고 시작버튼을 누르면 나오는 메뉴에서 git bash 파일을 찾아서 실행해주세요.
	git bash가 실행되면 cmd.exe 와 비슷한 화면이 나올거라고 생각합니다. (git bash의 사용방법은 리눅스와 비슷합니다. 혹시 써보신 경험이 있으시면 git 커맨드를 제외한 나머지 명령은 리눅스 커맨드를 사용하시면 됩니다.)
	실행된 git bash 화면에서 git --version 을 입력해 버전을 확인합니다. 버전이 표시가 되면 git이 정상적으로 설치되었다고 할 수 있습니다.

	2. git에 user 설정하기
	git bash 화면에서 다음의 커맨드를 입력합니다.
	git config --global user.name (github 회원가입시 등록하신 이름)
	git config --global user.email (github 회원가입시 등록하신 이메일주소)
	입력이 되었으면 잘 설정되었는지 보기 위해 다음의 커맨드를 입력하여 화면에 이름과 이메일 주소가 나오는지 확인합니다.
	git config --list
	
	3. github 계정에 ssh key 등록하기
	아래의 URL에 접속하셔서 따라해주세요.
	https://help.github.com/articles/generating-ssh-keys/#platform-windows

	단, 설명중 Step3에서 ssh-agent를 활성화시키는 과정에서는 git-bash를 실행시킨채로,
	두번째에 나와있는 커맨드인, eval $(ssh-agent -s)를 입력해주세요.
	집에 있는 윈도우 노트북에서 실행시켜 봤습니다만, 단지 ssh-agent -s 커맨드로는 잘 되지 않았습니다.

	4. 저에게 github에 등록하신 username 혹은 full name을 알려주세요!!
	혹시 이미 github에 제가 collaborator로 등록을 해드렸으면 여기는 skip해주세요.
	csharp_study 프로젝트에 소스코드를 업로드 하실 수 있도록 설정할 필요가 있습니다.
	그를 위해 username 혹은 full name을 알아야 하니 알려주시면 감사하겠습니다.

	5. git clone 실행
	소스코드를 받아오기 위해 일단 새로 폴더를 하나 생성합니다. 
	혹시 모르니 바탕화면에는 폴더를 만들지 말아주세요. 유저이름이 한자 혹은 한글로 설정된 경우 등에는 나중에 git 혹은 개발환경에서 소스코드를 읽어오지 못하는 경우가 발생할 수도 있습니다.
	git bash 화면을 열어 생성된 폴더로 이동합니다. 이동할 때에는 다음과 같은 커맨드를 사용합니다.
	cd (폴더 경로)
	생성된 폴더까지 이동을 마쳤으면 아래의 커맨드를 입력하여 clone을 실행합니다.
	git clone git@github.com:Byeonghyeon-Lee/csharp_study.git
	에러 없이 잘 실행되었다면 새로운 폴더 아래에 csharp_study라는 폴더가 생성이 되고 그 안에 github의 프로젝트 안에 있는 파일들이 다운로드 되어 있을것입니다.

이것으로 clone은 완료입니다.