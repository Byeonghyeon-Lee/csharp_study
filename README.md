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
	1. local 환경에 git 설치하기<br>
	`git-scm.com` (구글에서 git이라고 검색해도 나옵니다.)에 접속하셔서 깃 인스톨러를 다운받아 설치해주세요.<br>
	그리고 시작버튼을 누르면 나오는 메뉴에서 `git bash` 파일을 찾아서 실행해주세요.<br>
	git bash가 실행되면 cmd.exe 와 비슷한 화면이 나올거라고 생각합니다.<br>
	실행된 git bash 화면에서 `git --version` 을 입력해 버전을 확인합니다. 버전이 표시가 되면 git이 정상적으로 설치되었다고 할 수 있습니다.<br>

	2. git에 user 설정하기 <br>
	git bash 화면에서 다음의 커맨드를 입력합니다.<br>
	`git config --global user.name (github 회원가입시 등록하신 이름)`
	`git config --global user.email (github 회원가입시 등록하신 이메일주소)`
	입력이 되었으면 잘 설정되었는지 보기 위해 다음의 커맨드를 입력하여 화면에 이름과 이메일 주소가 나오는지 확인합니다.
	`git config --list`
	
	3. github 계정에 ssh key 등록하기<br>
	이곳에 적기에는 너무 설명이 길어질것 같으므로 ssh key 생성에 대해서는 생활코딩 홈페이지를 보고 설정해주세요.<br>
	https://opentutorials.org/course/785/4936<br>
	여기에서 gitlab ssh key win 동영상을 보시고 따라하시면 됩니다. ssh key를 생성해서 내용을 복사하는 곳까지만 보시면 됩니다.<br>
	단, 생성된 ssh key 파일 두개는 혹시 나중에 별도의 ssh key를 만드실 일이 생길 경우를 대비해 다른것과 구분되도록 파일 이름을 변경해주세요.

생성된 ssh key 파일중 pub 파일의 내용을 복사합니다(파일 내용을 복사하는것까지는 생활코딩의 동영상에 나와있을것이라 생각합니다.)<br>
웹브라우저의 github 프로젝트로 돌아갑니다.<br>
화면 우측 상단의 맨 오른쪽에 위치한 아이콘을 클릭하면 드롭다운 메뉴가 표시될텐데요, setting(혹은 설정)을 클릭합니다.<br>
이동한 화면에서 좌측 메뉴를 보면 SSH keys라는 메뉴가 있는데요, 클릭하여 이동합니다.<br>
Add SSH Key 버튼을 눌러 title에는 파일 이름 혹은 본인이 알아볼 수 있는 이름을, Key에는 방금 전에 복사한 .pub 파일의 내용을 붙여넣기 하여 Add Key 버튼을 누릅니다.