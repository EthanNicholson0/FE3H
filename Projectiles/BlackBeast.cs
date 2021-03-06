using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Projectiles
{
    public class BlackBeast : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 71;
            projectile.height = 47;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 600;
            projectile.spriteDirection = projectile.direction;
        }

        public override void AI()
        {
            projectile.velocity.Y += projectile.ai[0];
        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Item25, projectile.position);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            projectile.Kill();
        }
    }
}