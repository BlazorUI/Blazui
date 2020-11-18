using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Blazui.ServerRender;
using PuppeteerSharp;
using Xunit;
using Xunit.Abstractions;

namespace Blazui.Component.Test
{
    public class TabTest : SetupTest
    {
        public TabTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public async Task TestTab1Async()
        {
            await TestCaseAsync("�����ġ����ı�ǩҳ");
        }
        [Fact]
        public async Task TestTab2Async()
        {
            await TestCaseAsync("ѡ���ʽ�ı�ǩҳ");
        }
        [Fact]
        public async Task TestTab3Async()
        {
            await TestCaseAsync("��Ƭ���ı�ǩҳ");
        }

        private async Task TestCaseAsync(string name)
        {
            await TestCaseAsync("Tabs ��ǩҳ", name); 
        }

        [Fact]
        public async Task TestTab4Async()
        {
            await TestCaseAsync("����ߵı�ǩҳ");
        }
        [Fact]
        public async Task TestTab5Async()
        {
            await TestCaseAsync("�����¼�APIʵ�ֿɱ༭�ı�ǩҳ");
        }
        [Fact]
        public async Task TestTab6Async()
        {
            await TestCaseAsync("˫���ʵ�ֿɱ༭�ı�ǩҳ");
        }
    }
}
