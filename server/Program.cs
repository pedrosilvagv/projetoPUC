var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/configura/{interfaceRede}/{alias}/{enderecoIP}/{mascaraRede}", async context =>
{
	var interfaceRede = context.Request.RouteValues["interfaceRede"];
	var alias = context.Request.RouteValues["alias"];
	var enderecoIP = context.Request.RouteValues["enderecoIP"];
	var mascaraRede = context.Request.RouteValues["mascaraRede"];
	//
	System.Diagnostics.ProcessStartInfo process = new System.Diagnostics.ProcessStartInfo();
	process.UseShellExecute = false;
	process.WorkingDirectory = "/bin";
	process.FileName = "sh";
	//process.Arguments = $"/projetoPUC/script/configuraRede.sh {interfaceRede}{alias}{enderecoIP}{mascaraRede}";
	process.Arguments = $"/home/projeto/projetoPUC/scripts/exec.sh {interfaceRede} {alias} {enderecoIP} {mascaraRede}";
    process.RedirectStandardOutput = true;

	System.Diagnostics.Process cmd =  System.Diagnostics.Process.Start(process);
	// waiting to complete 
	cmd.WaitForExit();


	await context.Response.WriteAsync($"Interface: {interfaceRede}. Alias: {alias}. IP: {enderecoIP}. Mascara: {mascaraRede}");
});

app.Run();