using System;
using Xunit;
using System.Data;
using Moq;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using loja_depr.Controllers;
using loja_depr.Models.Colaborator;
using loja_depr.DAL;

namespace loja_depr.Tests
{
    public class ColaboratorsControllerTests
    {
        private readonly ColaboratorsController _controller;
        private readonly StoreDepartContext _context;

        public ColaboratorsControllerTests()
        {
            var options = new DbContextOptionsBuilder<StoreDepartContext>()
                .UseInMemoryDatabase(databaseName: "Teste_loja_depr")
                .Options;

            _context = new StoreDepartContext(options);
            _controller = new ColaboratorsController(_context);
        }
    }
}