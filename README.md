Deploy Serviço

Abrir Internet Information Services (IIS) manger
Clicar com o botao direito em Sites
Sites => "Add Web Site"
Na janela que irá abrir preencha o Site Name
Selecione Physical path
Ao clicar em ok um alert box irá surgir ele exibira informaçoes sobre a porta que por 
default será "80" caso deseje alterar clicar em nao caso contrario clicar em sim.
Em site clicar no site que foi criado.
Agora verificamos advanced setting do lado direito do painel e altere caso haja necessidade.
Clicar em Basic Settings em "Edit Application Pool" localizado no lado direito.
Selecione a versão em ".NET Framework version" e o "Managed pipeline mode" para "Integrated".
Agora podemos testar 
Clicar com o botao direito no site criado
Selecione "Manage Web Site" -> "Browse".


//Base de Dados.
Foi utilizado para o desafio o code first com base de dados atachada ao projeto.
caso deseje utilizar outra base alterar a connectionStrings no webConfig.

