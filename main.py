import disnake

from disnake.ext import commands

bot = commands.Bot(command_prefix="*", intents=disnake.Intents.all())


@bot.slash_command()
async def test(interaction: disnake.AppCmdInter):
	await interaction.send("комманда выполнена!RTMC")

bot.run("MTA5NzE3NjQzOTI3NjcyMDIzOA.GIFUtZ.P6hH4DEZZ1HjSeFVmJnQZHTl2BZ3KdJhj9VrqE")