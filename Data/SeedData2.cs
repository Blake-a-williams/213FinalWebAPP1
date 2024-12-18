using _213FinalWebAPP.Data;
using Blazor213FinalWebAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor213FinalWebAPP.Data
{
    public class SeedData2
{
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context1 = new _213FinalWebAPPContext(serviceProvider.GetRequiredService<DbContextOptions<_213FinalWebAPPContext>>());

            if (context1 == null || context1.FAQ == null)
            {
                throw new NullReferenceException("Null Blazor213FinalWebAppContext or FAQ DbSet");
            }
            if (context1.FAQ.Any())
            {
                return;
            }

            context1.FAQ.AddRange(
                new FAQ
                {
                    Question= "How do I adopt a dog from your shelter?",
                    Answer = "The adoption process starts by filling out an adoption application form on our website. After reviewing your application, we’ll schedule an interview to ensure the best match between you and our available dogs. We also require a home visit for safety and compatibility checks."
                },
                new FAQ
                {
                    Question = "Can I meet a dog before adopting?",
                    Answer = "Yes! if you're interested in a specific dog, we can arrange a meeting by appointment. Additionally we host regular adoption events where you can meet adoptable dogs"
                },
                new FAQ
                {
                    Question = "How do I volunteer or donate to the shelter?",
                    Answer = "You can volunteer by messaging us on our website, or filling out a form in person. Donations can be made online, in person, or by mail. We greatly appreciate donations of supplies like dog food, toys, and bedding."
                }, 
                new FAQ
                {
                    Question = "What should I bring with me when adopting a dog?",
                    Answer = "Please bring a valid photo ID, proof of address, and, if possible, a leash and collar for your new pet"
                }, 
                new FAQ
                {
                    Question = "Do you offer post-adoption training or support?",
                    Answer = "Yes! We provide resources, tips, and recommendations for local trainers to help you and your dog succeed together. We also offer follow-up support to address any questions or challenges."
                }
                );
            context1.SaveChanges();
        }
}
}
