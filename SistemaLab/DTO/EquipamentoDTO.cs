﻿using SistemaLab.Model.enums;
using System;

namespace SistemaLab.DTO
{
    public class EquipamentoDTO
    {
        public EquipamentoDTO(string nomeEquipamento, string modelo, string marca)
        {
            this.nomeEquipamento = nomeEquipamento;
            this.modelo = modelo;
            this.marca = marca;
        }

        public string nomeEquipamento { get; private set; }
        public StatusEquipamento statusEquipamento { get; private set; }
        public string marca { get; private set; }
        public string modelo { get; private set; }

        public string ObterDetalhes()
        {
            return $"Nome: {nomeEquipamento}\nModelo: {modelo}\nMarca: {marca}\nStatus: {statusEquipamento}";
        }
    }
}
