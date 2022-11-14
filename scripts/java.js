var url = "https://201.51.240.160:7199";
function alerta() {

    var interface = document.getElementById("input_ether").value;
    var alias = document.getElementById("input_alias").value;
    var ip = document.getElementById("input_ipv4").value;
    var mask = document.getElementById("input_mask").value;

    if (interface == "" || mask == "" || alias == "" || ip == "")
        return alert("Todos os campos devem ser preenchidos");

    else {

        if (!window.confirm("Tem certeza que deseja configurar a rede com as seguintes configurações? \n Interface.: " + interface + " \n Alias.: " + alias + " \n Endereço IP.: " + ip + " \n Mascara.: " + mask))
            return;
        else {
            alert("Vai executar o shell");
            executShell(interface, alias, ip, mask);

        }

    }

}

function executShell(interface, alias, ip, mask) {
    alert("Entrou no execute shell");
    var params = interface + "/" + alias + "/" + ip + "/" + mask;
    alert("Vai executar o getApi");
    getApiAsync("GET", "/configura", params, enviado, '');

}
function enviado(data) {
    console.log(data);
    alert("Comando Executado com Sucesso!");
}

function getApiAsync(type, metodo, params, callback, param) {
    alert("Entrou no getapi");
    var retorno = "";
    alert(url+metodo+"/"+params);
    window.location=url+metodo+"/"+params;
  
    return retorno;
}
